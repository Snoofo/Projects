
<?php include 'top-module.php'; ?>
    <title>Servicing</title>
    <script>

    </script>
<?php include 'middle-module.php'; ?>
    <div class="content">
      <div class="content1">
        <h2>Check Out</h2><br><!-- Image sourced from www.tyrepro.net.au for educational purposes only -->
        <div class="form">
          <?php
            $fname ='';
            $lname ='';
            $email ='';
            $phone ='';
            if (isset($_SESSION['user'])){
              $fname = $_SESSION['user']['firstName'];
              $lname = $_SESSION['user']['lastName'];
              $email = $_SESSION['user']['email'];
              $phone = $_SESSION['user']['phone'];
            }
          ?>
          <form action="processcheckout.php" method="post">
            First name: <input type="text" name="firstname" value="<?php echo $fname?>"
             autofocus required><br>
            Last name: <input type="text" name="lastname" value="<?php echo $lname?>" 
            required><br>
            Address: <input type="text" name="address" <?php echo $address?> required><br>
            E-mail: <input type="email" name="email" value="<?php echo $email?>" 
            required><br>
            Phone: <input type="text" name="phone" value="<?php echo $phone?>" 
            pattern='[0-9\(\)\+ ]{12,14}' required><br>
            <strong><u>Postage method</u></strong><br><br>
            <input type='radio' name='post' value='regPost' checked> Regular Post
            <input type='radio' name='post' value='courier'> Courier
            <input type='radio' name='post' value='expCourier'> Express Courier<br>
            Credit Card: <input type="text" name="ccNum" pattern='[0-9]{13,18}' required><br>
            <u>Expiry Date</u><br>Month 
            <select name='expMonth' required>
              <option value=''>---</option>
              <option value='1'>1</option>
              <option value='2'>2</option>
              <option value='3'>3</option>
              <option value='4'>4</option>
              <option value='5'>5</option>
              <option value='6'>6</option>
              <option value='7'>7</option>
              <option value='8'>8</option>
              <option value='9'>9</option>
              <option value='10'>10</option>
              <option value='11'>11</option>
              <option value='12'>12</option>
            </select>
            Year
            <select name='expYear' required>
              <option value=''>------</option>
              <option value='2015'>2015</option>
              <option value='2016'>2016</option>
              <option value='2017'>2017</option>
              <option value='2018'>2018</option>
              <option value='2019'>2019</option>
            </select><br><br>
            <input type='checkbox' name='signup' value='yes'> Sign me up for newsletters<br>
            <h2>$ <?php 
                  if (isset($_POST['total'])){
                    echo $_POST['total'];
                  }
                  ?>
            </h2>
            <input type="submit" value="Submit">
          </form>
        </div>
      </div>
    </div>
<?php include 'bottom-module.php'; ?>
<?php include_once("/home/eh1/e54061/public_html/wp/debug.php"); ?>