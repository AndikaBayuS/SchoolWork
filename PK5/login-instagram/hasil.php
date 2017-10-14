<!DOCTYPE html>
<html>
<head>
	<title>Blabla</title>
	<link rel="stylesheet" href="css/style.css">
</head>
<body>
<?php
	
$host= "localhost";
$user= "root";
$password= "";
$email=$_GET['email'];
$name=$_GET['name'];
$username=$_GET['username'];
$password=$_GET['password'];
?>

<div id="verif">
	<div class="Header">Your Login Info</div>
	<div class="hasil">
		<div class="name">
			Name : <?php echo" $name" ?><br>
		</div>

		<div class="username">
			Username : <?php echo" $username" ?><br>
		</div>

		<div class="email">
			Email : <?php echo" $email" ?><br>
		</div>

		<div class="password">
			Password : <?php echo" $password" ?><br>
		</div>

	</div>
</div>
</body>
</html>