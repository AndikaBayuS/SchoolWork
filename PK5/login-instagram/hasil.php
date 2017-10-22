<!DOCTYPE html>
<html>
<head>
	<title>Blabla</title>
	<link rel="stylesheet" href="css/style.css">
</head>
<body>
<?php
$host = "localhost";
$user = "root";
$password= "";
$email=$_GET['email'];
$name=$_GET['name'];
$username=$_GET['username'];
$userpassword=$_GET['password'];
 	if($username)
 	{
 		$conn=mysqli_connect ($host,$user,$password);
 		mysqli_select_db ($conn,'dbuser');
 		$sql="insert into tinfo values('$name','$username','$email','$userpassword')";
 		$hasil=mysqli_query($conn,$sql);
 	}
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
			Password : <?php echo" $userpassword" ?><br>
		</div>

	</div>
</div>
</body>
</html>