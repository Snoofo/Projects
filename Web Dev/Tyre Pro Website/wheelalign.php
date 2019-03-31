
<?php include 'top-module.php'; ?>
    <title>Wheel Alignment</title>
<?php include 'middle-module.php'; ?>
    <div class="content">
      <div class="content1">
        <h2>The Professionals in Artarmon</h2><br><!-- Image sourced from www.tyrepro.net.au for educational purposes only -->
        <h3>Booking Form</h3>
        <div class="form">
          <form action="http://coreteaching01.csit.rmit.edu.au/~e54061/wp/formprocessor.php" method="post">
            First name: <input type="text" name="firstname" autofocus required><br>
            Last name: <input type="text" name="lastname" required><br>
            Booking date: <input type="date" name="date" required><br>
            Booking time: <input type="time" name="time" required><br>
            E-mail: <input type="email" name="email" required><br>
            <input type="hidden" name="productID" value="wheelalign">
            <h2>$ 79</h2>
            <input type="submit" value="Submit">
          </form>
          <img class="image" src= "wheelalign.png" alt='wheelalign' />
        </div>
      </div>
    </div>
<?php include 'bottom-module.php'; ?>
<?php include_once("/home/eh1/e54061/public_html/wp/debug.php"); ?>