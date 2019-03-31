<?php
	session_start();
	if ($_POST['productID']=="contityre"){
		if (!isset($_SESSION['cart']['products']['conti'])){
		  $_SESSION['cart']['products']['conti'] = $_POST['quantity'];
		}
		else {
		  $_SESSION['cart']['products']['conti'] += $_POST['quantity'];
		}
	}
	else if ($_POST['productID']=="michelintyre"){
		if (!isset($_SESSION['cart']['products']['michelin'])){
		  $_SESSION['cart']['products']['michelin'] = $_POST['quantity'];
		}
		else {
		  $_SESSION['cart']['products']['michelin'] += $_POST['quantity'];
		}
	}
	else if ($_POST['productID']=="bridestyre"){
		if (!isset($_SESSION['cart']['products']['bstone'])){
		  $_SESSION['cart']['products']['bstone'] = $_POST['quantity'];
		}
		else {
		  $_SESSION['cart']['products']['bstone'] += $_POST['quantity'];
		}
	}
	header('Location: cart.php');
?>