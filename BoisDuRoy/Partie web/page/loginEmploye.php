
<?php require('../common/header.html'); ?>

<body>
    <div class='contain-homePage'>
        <form action="../login.php" method="post" id="formConnexion" class='form-login'>
            <div class="group">
                <input type="tex" id="form1Login" name="matricule_emp" required>
                <span class="highlight"></span>
                <span class="bar"></span>
                <label for="matricule_emp">Matricule</label>
            </div>
    
            <div class="group">
                <input type="password" id="form1Mdp" name="mdp_emp" required>
                <span class="highlight"></span>
                <span class="bar"></span>
                <label for="mdp_emp">Mot de passe</label>
            </div>
    
            <input type="submit" id="btnConnecter" value="Se Connecter" class='btn-login'/>  
        </form>
    
        <div class='img-area'>
            <img src="../public/img/fonduHomepage.png" class="fondu">
            <img src="../public/img/workHomepage.png" alt="img homePage" class="img-homepage">
        </div>
    </div>

</body>
</html>