<?php
header("Content-type: text/xml");
header("Connection: close");
header("Expires: -1");

$servername   = "localhost";
$database = "asterisk";
$username = "freepbxuser";
$password = "*** Password found in /etc/freepbx.conf file ['AMPDBPASS'] ***";

// Create connection
$conn = new mysqli($servername, $username, $password, $database);
// Check connection
if ($conn->connect_error) {
   die("Connection failed: " . $conn->connect_error);
}
//  echo "Connected successfully";

$sqlUsers = "SELECT name, extension from asterisk.users ORDER BY name";
$resultUsers = $conn->query($sqlUsers);

print("<CiscoIPPhoneDirectory>\n");
print("\t<Title>Extension List</Title>\n");
print("\t<Prompt>Select an Extension</Prompt>\n");

if ($resultUsers->num_rows > 0) {
  // output data of each row
  while($row = $resultUsers->fetch_assoc()) {
    //echo "name: " . $row["name"]. " - extension : " . $row["extension"]. "<br>";

    print("\t<DirectoryEntry>\n");

    print("\t\t<Name>");
    print($row["name"]);
    print("</Name>\n");

    print("\t\t<Telephone>");
    print($row["extension"]);
    print("</Telephone>\n");


    print("\t</DirectoryEntry>\n");
  }
} else {
  //echo "0 results";
  print("\n");
}

print("\t<SoftkeyItem>");
print("\t\t<Name>Exit</Name>");
print("\t\t<URL>SoftKey:Exit</URL>");
print("\t\t<Position>1</Position>");
print("\t</SoftkeyItem>");

print("\t<SoftkeyItem>");
print("\t\t<Name>Dial</Name>");
print("\t\t<URL>SoftKey:Dial</URL>");
print("\t\t<Position>2</Position>");
print("\t</SoftkeyItem>");

print("\t<SoftkeyItem>");
print("\t\t<Name>Prev</Name>");
print("\t\t<URL>SoftKey:Exit</URL>");
print("\t\t<Position>3</Position>");
print("\t</SoftkeyItem>");

print("\t<SoftkeyItem>");
print("\t\t<Name>Next</Name>");
print("\t\t<URL>SoftKey:Exit</URL>");
print("\t\t<Position>4</Position>");
print("\t</SoftkeyItem>");

print("</CiscoIPPhoneDirectory>");

$conn->close();

?>