<?php

require_once(dirname(__FILE__).'/lib/config.php');

$title = "FreePBX Inbound Call Log";
$description = "List of inbound calls from OBi110 ATA.";


$format = $_GET['format'];
$inc_headers = $_GET['inc_headers'];

switch($format) {
	case "text":
		header("Content-type: text/plain");
		break;
	case "xml":
		header("Content-type: text/xml");
		break;
	default:
		header("Content-type: text/html");
		break;
}

header("Connection: close");
header("Expires: -1");

// Create connection
$conn = new mysqli($servername, $username, $password, $database);
// Check connection
if ($conn->connect_error) {
   die("Connection failed: " . $conn->connect_error);
}

$sqlCalls = file_get_contents("./queries/callerid.txt",  FILE_USE_INCLUDE_PATH);
$resultCalls = $conn->query($sqlCalls);

switch($format) {
	case "text":
		if ($resultCalls->num_rows > 0) {
			$columns = array();

			while($row = $resultCalls->fetch_assoc()) {
				// Get field names and print them if this is the first row
				if (empty($columns)) {
					$columns = array_keys($row);
					$colIdx = 0;
					if($inc_headers != "no") {
						foreach($columns as $_column) {
							if($colIdx > 0) {
								print("\t");
							}
							print($_column);
							$colIdx++;
						}
						print("\n");
					}
				}
				
				$colIdx = 0;
				foreach($columns as $_column) {
					if($colIdx > 0) {
						print("\t");
					}
					print($row[$_column]);
					$colIdx++;
				}
				print("\n");
			}
		} else {
			print("");
		}
		break;
	case "xml":
		print("<?xml version=\"1.0\" ?>\n");
		print("<Callers>\n");
		
		if ($resultCalls->num_rows > 0) {
			$columns = array();
			
			while($row = $resultCalls->fetch_assoc()) {				
				if (empty($columns)) {
					$columns = array_keys($row);
				}
				
				print("\t<Call>\n");
				
				foreach($columns as $_column) {
					print("\t\t<" . str_replace(" ", "_", $_column) . ">" . htmlspecialchars($row[$_column], ENT_XML1) . "</" . str_replace(" ", "_", $_column) . ">\n");
				}
				
				print("\t</Call>\n");
			}
		}
		
		print("</Callers>\n");
		break;
	default:
		$head = str_replace("*** TITLE ***", $title, file_get_contents("./parts/head.txt",  FILE_USE_INCLUDE_PATH));
		$foot = file_get_contents("./parts/foot.txt",  FILE_USE_INCLUDE_PATH);
		
		print($head);

		print("\t\t<p>" . $description . "</p>\n");

		if ($resultCalls->num_rows > 0) {
			$columns = array();
			
			print("\t\t<table>\n");
			
			while($row = $resultCalls->fetch_assoc()) {				
				if (empty($columns)) {
					$columns = array_keys($row);
					
					print("\t\t\t<tr>");
					
					foreach($columns as $_column) {
						print("\t\t\t\t<th>" . $_column . "</th>\n");
					}
					
					print("</tr>\n");
				}
				
				print("\t\t\t<tr>");
					
				foreach($columns as $_column) {
					print("\t\t\t\t<td>" . $row[$_column]  . "</td>\n");
				}
				
				print("</tr>\n");
				
			}
			
			print("\t\t</table>\n");
		} else {
			//echo "0 results";
			print("<p><i>No Results</i></p>\n");
		}

		print($foot);
		break;
}

$conn->close();

?>