
<?php include 'top-module.php'; ?>
    <title>Cart</title>
      // function deleteC(){
      //   <?php
      //     unset($_SESSION['cart']['products']['michelin']);
      //   ?>
      // }
<?php include 'middle-module.php'; ?>

    <div class="content">
      <div class="content1">
        <h3>Your Cart</h3>
        <div class="form">
          <form action="checkout.php" method="post">
          <?php
            if (isset($_SESSION['cart'])){
              $total = 0;
                if (isset($_SESSION['cart']['products']['conti'])){
                  $qty = $_SESSION['cart']['products']['conti'];
                  if (isset($_SESSION['user'])){
                    $price = $qty*$_SESSION['products']['conti']*
                    (1-(0.01*$_SESSION['user']['discountP1']));
                  }
                  else {
                    $price = $qty*$_SESSION['products']['conti'];
                  }
                  $total += $price;
                  echo "<div class='cart'><h5><strong>Continental</strong> Sport Contact</h5>".
                  "<h2><span class='a'>Qty: </span>".$_SESSION['cart']['products']['conti'].//"<button type='button' onclick='deleteC()' value='conti'>x</button>".
                  "<br><span class='a'>Sub total: </span>$".$price."</h2></div>.".
                  "<input type='hidden' id='conti' name='conti' value='".$qty."'>";
                }
                if (isset($_SESSION['cart']['products']['michelin'])){
                  $qty = $_SESSION['cart']['products']['michelin'];
                  if (isset($_SESSION['user'])){
                    $price = $qty*$_SESSION['products']['michelin']*
                    (1-(0.01*$_SESSION['user']['discountP2']));
                  }
                  else {
                    $price = $qty*$_SESSION['products']['michelin'];
                  }
                  $total += $price;
                  echo "<div class='cart'><h5><strong>Michelin</strong> Pilot Sport</h5>".
                  "<h2><span class='a'>Qty: </span>".$_SESSION['cart']['products']['michelin'].//"<button type='button' onclick='deleteC()' value='conti'>x</button>".
                  "<br><span class='a'>Sub total: </span>$".$price."</h2></div>".
                  "<input type='hidden' id='michelin' name='michelin' value='".$qty."'>";

                }
                if (isset($_SESSION['cart']['products']['bstone'])){
                  $qty = $_SESSION['cart']['products']['bstone'];
                  if (isset($_SESSION['user'])){
                    $price = $qty*$_SESSION['products']['bstone']*
                    (1-(0.01*$_SESSION['user']['discountP3']));
                  }
                  else {
                    $price = $qty*$_SESSION['products']['bstone'];
                  }
                  $total += $price;
                  echo "<div class='cart'><h5><strong>Bridgestone</strong> Potenza</h5>".
                  "<h2><span class='a'>Qty: </span>".$_SESSION['cart']['products']['bstone'].
                  "<br><span class='a'>Sub total: </span>$".$price."</h2></div>".
                  "<input type='hidden' id='bstone' name='bstone' value='".$qty."'>";
                }
                echo "<input type='hidden' id='total' name='total' value='".$total."'>";
                echo "<h2><span class='a'>Total: </span>$".$total."</h2>";
                echo "<input type='submit' value='Check Out Now'>";
                echo "<a href='products.php' style='color: black'>Back to products</a>";
              }
            else {
              echo "<p>You have nothing in your cart yet!<br>".
              "<a href='products.php'>Click here</a> to browse our products.</p>";
            }
          ?>
          </form>
        </div>
      </div>
    </div>

<?php include 'bottom-module.php'; ?>
<?php include_once("/home/eh1/e54061/public_html/wp/debug.php"); ?>