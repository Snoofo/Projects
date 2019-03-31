
<?php include 'top-module.php'; ?>
    <title>Product</title>
<?php include 'middle-module.php'; ?>
    <div class="content">
      <div class="content1">
        <?php
          if ($_GET['pid']=='bstone'){
            include ('bridgestyre.php');
          }
          else if ($_GET['pid']=='conti'){
            include ('contityre.php');
          }
          else if ($_GET['pid']=='michelin'){
            include ('michelintyre.php');
          }
        ?>
      </div>
    </div>
<?php include 'bottom-module.php'; ?>
<?php include_once("/home/eh1/e54061/public_html/wp/debug.php"); ?>