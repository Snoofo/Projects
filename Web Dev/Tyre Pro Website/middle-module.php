    <link rel="stylesheet" type="text/css" href="mystyle.css">
    <script src="jscript.js">
    </script>
   </head>

   <body>
     <div class="container">
     <div class="header">
       <!-- Image sourced from www.tyrepro.net.au for educational purposes only -->
        <img src="logo1.png" alt='logo'/>
        <!-- <div class="login">
          <a class="login" href="login.php">Login</a>
        </div> -->
        <div class="loginbar">
          
          <?php 
            if (!isset($_SESSION['user'])){
              echo "<div class='logindiv' style='width:200px'><form action='processlogin.php' method='post'>
              Email: <input class='smallInput' type='email' id='email' name='email' placeholder='Enter Email' required><br>
              Password: <input class='smallInput' type='password' id='password' name='password' placeholder='Password' required><br>
              <a href='cart.php'>Your Cart</a><input class='login' type='submit' value='Login'>
              </form></div>";
            
            }
            else if ($_SESSION['user']['firstName']=="admin"){
              echo "<div class='logindiv'><a href='orders.php'>Orders</a>".
              "<br><a href='processlogout.php'>Login out</a></div>";
            }
            else {
              echo "<a href='cart.php'>Your Cart</a><br>
                   <div class='logindiv'><span style='color: orange;'>Logged in as </span>
                   <span style='font-weight: bolder; font-size: x-large;'>".
                   $_SESSION['user']['firstName']."</span><br><a href='processlogout.php'>Login out</a></div>";
            }
          ?>
        </div>
        </div>
     <div class="nav">
       <a href="index.php">Home</a><br>
       <a href="products.php">Tyres</a><br> 
       <a href="services.php">Services</a><br> 
       <a href="contact.php">Contact Us</a><br>
     </div>