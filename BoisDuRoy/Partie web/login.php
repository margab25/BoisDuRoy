<?php
    require('common/header.html');
    session_start(); 
    
    include('model/connexionBDD.php') ;
    if (isset($_POST['matricule_emp']) && isset($_POST['mdp_emp'])) {
        $matricule_emp = htmlspecialchars($_POST['matricule_emp']);
        $mdp_emp = $_POST['mdp_emp'];
    
        $result = $bdd->prepare("SELECT * FROM employe WHERE matricule_emp = ? AND mdp_emp = PASSWORD(?) ");
        $result->execute(array($matricule_emp,$mdp_emp));
    
        if ($result->rowCount() > 0) {
            $_SESSION['matricule_emp'] = $matricule_emp;
            $_SESSION['mdp_emp'] = $mdp_emp;

            header('Location:page/information.php');
        } else {
            echo "Matricule ou mot de passe incorrect";
        }
    } 

    require('common/footer.html');
?>
