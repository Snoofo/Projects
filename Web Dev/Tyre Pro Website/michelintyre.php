
        <div class="tyre"><!-- Image sourced from www.continental.co.uk for educational purposes only -->
          <div class="prodmain" style="background-image: url(michtyre.png); background-size: cover">
            <h3>Michelin Pilot Sport</h3>
            <h3>In Stock:</h3>
            <p><?php
              if (!isset($_SESSION['user'])){
                $price = $_SESSION['products']['michelin'];
                echo "$".number_format($price, 2, '.', '');
              }
              else {
                $price = ($_SESSION['products']['michelin'] * (1-(0.01 * $_SESSION['user']['discountP2'])));
                echo "$".number_format($price, 2, '.', '');
              }
            ?></p>
          </div>
          <form action="processcart.php" method="post" oninput="qtyCheck(); inputCheck(); 
          document.getElementById('total').value = ((quantity.value)*(price.value)).toFixed(2)">
            <p>Enter Quantity: 
              <button class="qtyButton" type="button" onclick="downButton()">-</button>
              <input type="text" id="quantity" name="quantity" min="1" required>
              <button class="qtyButton" type="button" onclick="upButton()">+</button>
              <span class="error" id="qtyError"></span>
            </p>
            <input type="hidden" name="productID" value="michelintyre">
            <input type="hidden" id="price" value="<?php echo $price ?>">
            <h2>Total: <output id="total" for="price quantity" value="0"></output></h2>
            <input type="submit" value="Add to Cart">
          </form>
        </div>
      </div>