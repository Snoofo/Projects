
<?php include 'top-module.php'; ?>
    <title>Cart</title>
<?php include 'middle-module.php'; ?>
    <div class="content">
      <div class="content1">
        <h3>Orders</h3>
        <?php
          $file = fopen('orders.txt', 'r');
          while (($line = fgetcsv($file, "\t", '"'))!==false){
            $row = count($line);
            for ($i=0; $i<$row; $i++){
              echo $line[$i];
            }
            echo "<br>";
          }
        ?>

        <p><a href='index.php'>Click here to return</a><br>
           <a href='clear-orders.php'>Click here to clear orders</a></p>
      </div>
    </div>

<?php include 'bottom-module.php'; ?>
<?php include_once("/home/eh1/e54061/public_html/wp/debug.php"); ?>