
<?php include 'top-module.php'; ?>
    <title>Login</title>
<?php include 'middle-module.php'; ?>

    <div class="content">
      <div class="content1">
      	<h2>
      	  User Login
      	</h2>
      	<div class="form">
      	  <form action="http://coreteaching01.csit.rmit.edu.au/~e54061/wp/formprocessor.php" method="post">
      	    Enter email:
      	    <input type="email" id="email" name="email" required><br>
      	    Enter password:
      	    <input type="password" id="password" name="password" required>
      	    <button type="submit">Submit</button>
      	  </form>
        </div>
      </div>
    </div>

<?php include 'bottom-module.php'; ?>
<?php include_once("/home/eh1/e54061/public_html/wp/debug.php"); ?>