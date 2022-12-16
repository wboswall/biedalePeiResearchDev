<!DOCTYPE html>
	<head>
		<title>Placeholder Title</title>
		</style>

		</style>
			<script>
				function display(){
					alert("Welcome to PHP!");
				}


			</script>
	</head>

	<body>
		<script>
			display();
		</script>
		<?php
			if (strpos($_SERVER['HTTP_USER_AGENT'], 'MSIE') !== FALSE)
			{
				echo "You are using Internet Explorer.</br />";
			}
		
		?>
		
		<?php

			echo nl2br("Hello\r\n");
			echo nl2br("\r\n");
			echo("<p>I'm a PHP script!</p>")
			#echo $_SERVER['HTTP_USER_AGENT'];
		 ?>
		
		<?php
		
			#phpinfo();
			#echo "Current PHP version: " . phpversion();
			#echo phpversion();
		?>
		<?php
		
			# this is a php comment using the UNIX shell style
			// this is a comment using C style commenting style
			/*This is a comment using C style comments style */
			# It is better to use the "#" because PHP is almost always ran on UNIX web servers such as LINUX web servers.
		
		?>
		<form action ="index.php" method = "post">
			<p>Your name: <input type="text" name="name" /></p>
			<p>Your age: <input type="text" name="age" /></p>
			<p><input type="submit" /></p>
			
		</form>
		<p><? echo htmlspecialchars ($_POST['name']); ?>. You are <?php echo (int) ($_POST['age']);?> years old.</p>
		<a href="https://stackoverflow.com/questions/6497833/php-opendir-to-list-folders-only">To shorten the url to only show the folders after the domain</a>
	</body>

</html>

