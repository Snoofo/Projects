
<?php include 'top-module.php'; ?>
    <title>Cart</title>
<?php include 'middle-module.php'; ?>
    <div class="content">
      <div class="content1">
        <h3>Confirming your Orders</h3>
        <div><div class='heading'>Product</div><div class='heading'>Quantity
                  </div><div class='heading'>Sub-total</div></div>
        <?php
              $total = 0;
                if (isset($_SESSION['cart']['products']['conti'])){
                  $qty = $_SESSION['cart']['products']['conti'];
                  $price = $qty*$_SESSION['products']['conti'];
                  echo "<div><div class='order'>Continental</div><div class='order'>".$qty.
                  "</div><div class='order'>".$price."</div></div>";
                  $total += $price;
                }
                if (isset($_SESSION['cart']['products']['michelin'])){
                  $qty = $_SESSION['cart']['products']['michelin'];
                  $price = $qty*$_SESSION['products']['conti'];
                  echo "<div><div class='order'>Michelin</div><div class='order'>".$qty.
                  "</div><div class='order'>".$price."</div></div>";
                  $total += $price;
                }
                if (isset($_SESSION['cart']['products']['bstone'])){
                  $qty = $_SESSION['cart']['products']['bstone'];
                  $price = $qty*$_SESSION['products']['conti'];
                  echo "<div><div class='order'>Bridgestone</div><div class='order'>".$qty.
                  "</div><div class='order'>".$price."</div></div>";
                  $total += $price;
                }
              echo "<h2>Total : ".$total."</h2>";
              unset($_SESSION['cart']);
              ?>
              <p><a href='index.php'>Click here to return</a></p>
      </div>
    </div>

<?php include 'bottom-module.php'; ?>
<?php include_once("/home/eh1/e54061/public_html/wp/debug.php"); ?>