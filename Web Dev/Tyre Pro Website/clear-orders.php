<?php
	session_start();
	$file = fopen('orders.txt', 'w');
	fwrite($file , "");
	header('Location: index.php');
?>