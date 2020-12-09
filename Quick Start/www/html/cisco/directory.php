<?php
header ("content-type: text/xml");
$xtn = array_key_exists('xtn', $_GET) ? $_GET['xtn'] : NULL;
$mode = array_key_exists('mode', $_GET) ? $_GET['mode'] : NULL;
$url = "http://".$_SERVER['HTTP_HOST'].$_SERVER['PHP_SELF'];
if (!@include_once(getenv('FREEPBX_CONF') ? getenv('FREEPBX_CONF') : '/etc/freepbx.conf')) {
    include_once('/etc/asterisk/freepbx.conf');
}
// -----
switch ($mode) {
    case "extensions":
        echo directoryShow("extensions", $url, $xtn);
    break;
    case "groups":
        echo directoryShow("groups", $url, $xtn);
    break;
    case "personal":
        echo directoryShow("personal", $url, $xtn);
    break;
    default:
        echo directoryMenu($url, $xtn);
    }
// -----
function directoryMenu($url, $xtn) {
    $menudata = array(
        array('Internal Phonebook', "$url?mode=extensions")
        ,array('Ring groups', "$url?mode=groups")
        ,array('Personal contacts', "$url?mode=personal&amp;xtn=$xtn")
    );
    $xml = new SimpleXMLElement('<CiscoIPPhoneMenu/>');
    $xml -> addChild('Prompt', 'Select a directory');
 
    foreach ($menudata as $menuitem) {
        $menuItem = $xml -> addChild('MenuItem');
        $menuItem -> addChild('Name', $menuitem[0]);
        $menuItem -> addChild('URL', $menuitem[1]);
    }
    return ($xml->asXML());
}
// -----
function directoryShow($mode, $url, $xtn) {
    global $db;
    switch ($mode) {
        case "extensions":
            $sql = "SELECT name, extension FROM users WHERE name NOT LIKE '%FAX%' AND extension < 400 ORDER BY name";
            $title = "Internal directory";
            $prompt = "Select a name";
        break;
        case "groups":
            $sql = "SELECT description, grpnum FROM ringgroups WHERE grpnum < 599 ORDER BY description";
            $title = "Department directory";
            $prompt = "Select a group";
        break;
        case "personal":
            $sql = "
                SELECT
                    CONCAT(contactmanager_group_entries.displayname, ' (', contactmanager_entry_numbers.type,')') AS 'name'
                    ,contactmanager_entry_numbers.number AS 'extension'
                FROM contactmanager_groups 
                LEFT JOIN contactmanager_group_entries ON contactmanager_groups.id = contactmanager_group_entries.groupid
                LEFT JOIN contactmanager_entry_numbers ON contactmanager_group_entries.id = contactmanager_entry_numbers.entryid 
                WHERE contactmanager_groups.name = '$xtn'
                ORDER BY contactmanager_group_entries.displayname
            ";
            $title = "Personal contacts";
            $prompt = "Select a name";
        break;
        default:
        return;
    }
 
    $results = $db->getAll($sql, DB_FETCHMODE_ORDERED);
    $numrows = count($results);
    $endoflist = false;
    $xml = new SimpleXMLElement('<CiscoIPPhoneDirectory/>');
    $xml -> addChild('Title', $title);
    $xml -> addChild('Prompt', $prompt);
 
    $page = array_key_exists('page', $_GET) ? $_GET['page'] : 0;
    $count = $page * 32;
 
    for ($row=$count; $row <= $count+31; $row++) {
        if (is_null($results[$row][0])) {
            $endoflist = true;
        } else {
            $endoflist = false;
            $directoryEntry = $xml -> addChild('DirectoryEntry');
            $directoryEntry -> addChild('Name', $results[$row][0]);
            $directoryEntry -> addChild('Telephone', $results[$row][1]);
        }
    }
 
    $softkey = $xml -> addChild('SoftKeyItem');
    $softkey -> addChild('Name', 'Dial');
    $softkey -> addChild('URL', 'SoftKey:Dial');
    $softkey -> addChild('Position', '1');
    
    $softkey = $xml -> addChild('SoftKeyItem');
    $softkey -> addChild('Name', 'Exit');
    $softkey -> addChild('URL', 'SoftKey:Exit');
    $softkey -> addChild('Position', '3');
 
    if ($page > 0) {
        $softkey = $xml -> addChild('SoftKeyItem');
        $softkey -> addChild('Name', '<<');
        $softkey -> addChild('URL', 'SoftKey:Exit');
        $softkey -> addChild('Position', '2'); 
    }
 
    if (!$endoflist) {
        $softkey = $xml -> addChild('SoftKeyItem');
        $softkey -> addChild('Name', ">>");
        $softkey -> addChild('URL', "$url?mode=$mode&amp;page=".++$page);
        $softkey -> addChild('Position', '4');
    }
    return ($xml->asXML()); 
}
?>