<?php
  session_start();
  if ($_POST['email']=="admin@tyrepro.net.au" &&
      $_POST['password']=="tyrepropassword"){
      $_SESSION['user']['firstName'] = "admin";
      header('Location: index.php');
  }
  else{
    $file = fopen('customers.txt','r');
    $firstLine = true;
    $login = false;
    while (($lines = fgetcsv($file, "\t", '"')) !== false){
      foreach ($lines as &$line) {
        $line=trim($line);
      }
      if ($firstLine){
        $firstLine = false;
        continue;
      }
      else {
        if ($_POST['email']==$lines[2] && $_POST['password']==$lines[3]){
    	    $_SESSION['user']['firstName'] = "$lines[0]";
    	    $_SESSION['user']['lastName'] = "$lines[1]";
    	    $_SESSION['user']['email'] = "$lines[2]";
    	    $_SESSION['user']['password'] = "$lines[3]";
    	    $_SESSION['user']['cryptPassword'] = "$lines[4]";
    	    $_SESSION['user']['phone'] = "$lines[5]";
    	    $_SESSION['user']['discountP1'] = "$lines[6]";
          $_SESSION['user']['discountP2'] = "$lines[7]";
          $_SESSION['user']['discountP3'] = "$lines[8]";
          $login = true;
          break;
        }
      }
    }
    if (!$login){
      
    }
    fclose($file);
    header('Location:'.$_SERVER['HTTP_REFERER']);
    }
?>