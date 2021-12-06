<?php 
  session_start();
  if(isset($_SESSION['unique_id'])){
    header("location: principal.php");
  }
?>

<?php include_once "header.php"; ?>
<body>
  <div class="wrapper">
    <section class="form signup">
      <header>Clinic On.</header>
      <form action="" method="POST" enctype="multipart/form-data" autocomplete="off">
        <div class="error-text"></div>
        <div class="name-details">
          <div class="field input">
            <label>Primeiro nome</label>
            <input type="text" name="fname" placeholder="Primeiro nome" required>
          </div>
          <div class="field input">
            <label>Último nome</label>
            <input type="text" name="lname" placeholder="Último nome" required>
          </div>
        </div>
        <div class="field input">
          <label>Email</label>
          <input type="text" name="email" placeholder="Insira seu email" required>
        </div>
        <div class="field input">
          <label>Senha</label>
          <input type="password" name="password" placeholder="Insira nova senha" required>
          <i class="fas fa-eye"></i>
        </div>
        <div class="field image">
          <label>Selecionar foto</label>
          <input type="file" name="image" accept="image/x-png,image/gif,image/jpeg,image/jpg" required>
        </div>
        <div class="field button">
          <input type="submit" name="submit" value="Entrar">
        </div>
      </form>
      <div class="link">Já possui cadastro? <a href="login.php">Faça login aqui.</a></div>
    </section>
  </div>

  <script src="javascript/pass-show-hide.js"></script>
  <script src="javascript/signup.js"></script>

</body>
</html>
