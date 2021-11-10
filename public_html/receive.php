<?php
require_once "class.trigger.inc.php";

function guid()
{
	mt_srand((double)microtime(false) * 10000);

	$rand = mt_rand(1000000, 9999999);
	$timestamp = date("HisYmd");
	$uniqid = uniqid(mt_rand(), true);

	$characters = strtoupper(md5($rand . $timestamp . $uniqid));
	$guid = preg_replace("/^([0-9A-F]{8})([0-9A-F]{4})([0-9A-F]{4})([0-9A-F]{4})([0-9A-F]{12})$/is", "$1-$2-$3-$4-$5", $characters);

	return $guid;
}



$guid = guid();

$id = $_POST["guid"];

$types = ["database", "backup", "invoice", "report", "schema", "json"];
$type = $_POST["type"]; // database, backup, invoice, report: $_POST["type"]
if(!in_array($type, $types)) $type = "unknown";

$received = "../../received/{$type}/{$guid}.{$type}";
if(is_uploaded_file($_FILES[$type]["tmp_name"]))
{
	move_uploaded_file($_FILES[$type]["tmp_name"], $received);
	$trigger = new trigger();
	$trigger->_strike($type, $received);
}

ob_start();
	print_r($_SERVER);
	print_r($_FILES);
$input = ob_get_clean();

$file = "../test.log";
file_put_contents($file, $input);

// echo $input;
echo $guid;
