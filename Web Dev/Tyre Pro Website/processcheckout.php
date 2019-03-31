<?php
	session_start();
	if (isset($_POST['firstname']) &&
		isset($_POST['lastname']) &&
		isset($_POST['email']) &&
		isset($_POST['address']) &&
		isset($_POST['phone']) &&
		isset($_POST['post']) &&
		isset($_POST['expMonth']) &&
		isset($_POST['expYear'])){
		$file = fopen('orders.txt', 'w');
		$fname = "\"".$_POST['firstname']."\""."\t";
		fwrite($file, $fname);
		$lname = "\"".$_POST['lastname']."\""."\t";
		fwrite($file, $lname);
		$email = "\"".$_POST['email']."\""."\n";
		fwrite($file, $email);
		if (isset($_SESSION['cart']['conti'])){
			$conti = $_SESSION['cart']['conti'];
			fwrite($file, $conti);
		}
		if (isset($_SESSION['cart']['bstone'])){
			$bstone = $_SESSION['cart']['bstone'];
			fwrite($file, "Bridgestone=".$bstone."\n");
		}
		if (isset($_SESSION['cart']['michelin'])){
			$mich = $_SESSION['cart']['michelin'];
			fwrite($file, "Michelin=".$mich."\n");
		}
		fwrite($file, "\n");
		header('Location: confirmorders.php');
	}
?>