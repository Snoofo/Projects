  var qty = 0;

  function upButton(){
    console.log('enter');
    clearError();
    qty = document.getElementById('quantity').value;
    document.getElementById('quantity').value = ++qty;
    document.getElementById('total').value = ((quantity.value)*(price.value)).toFixed(2);
    console.log('exit');
  }

  function downButton(){
    console.log('enter');
    clearError();
    qty = document.getElementById('quantity').value;
    if (qty > 1){
      document.getElementById('quantity').value = --qty;
      document.getElementById('total').value = ((quantity.value)*(price.value)).toFixed(2);
    }
  }

  function qtyCheck(){
  	clearError();
  	qty = document.getElementById('quantity').value;
  	if (qty <= 0){
  		document.getElementById('qtyError').innerHTML = "<br>Invalid entry";
      document.getElementById('quantity').value = null;
      document.getElementById('quantity').style.border = "solid 2px rgb(250,0,0)";
  		return false;
  	}
  	else {
      qty = document.getElementById('quantity').value;
  		return true;
  	}
  }

function inputCheck(){
  qty = document.getElementById('quantity').value;
  var patt = new RegExp("[^0-9]");
  var valid = patt.exec(qty);
  console.log(valid);
  if (valid == null){
    console.log("in");
    return true;
  }
  else {
    document.getElementById('qtyError').innerHTML = "<br>Invalid entry";
    document.getElementById('quantity').value = null;
    console.log("out");
    return false;
  }
}
function delete(tyre){
  <?php
    unset($_SESSION['cart']['products'][$tyre]);
  ?>
}

  // function validate(){
  //   qty = document.getElementById('quantity').value;

  // }

  // function submit(){
  //   var value = document.getElementById('quantity');
  //   if (value > 0){
  //     return true;
  //   }
  //   else{
  //     document.getElementById('quantity').value = 0;
  //     alert="Please enter a positive number";
  //     return false;
  //   }
  // }

  function clearError(){
  	errors = document.getElementsByClassName('error');
  	for (i = 0; i < errors.length; i++){
  		errors[i].innerHTML = "";
  	}
  }