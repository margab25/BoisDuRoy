<?php
    require('../common/header.html');
    require('../login.php');
    include('../common/navBar.php');
    include('../model/connexionBDD.php');

    $matricule_emp = $_SESSION['matricule_emp'];

    function employe_info($bdd, $matricule_emp) {
        $cmd = $bdd->prepare("SELECT * FROM employe INNER JOIN service ON employe.id_service = service.id_service INNER JOIN fonction ON employe.id_fonction = fonction.id_fonction INNER JOIN etat ON employe.matricule_emp = etat.matricule_emp WHERE employe.matricule_emp = ? ;");
        $cmd->bindParam(1, $matricule_emp);
        $cmd->execute();
        $result = $cmd->fetch(PDO::FETCH_ASSOC);
        return $result;
    }
    $employe = employe_info($bdd, $matricule_emp);

    function GenereMdp() {
        $car = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-=+;:,.?";
        $mdp = '';
        $length = strlen($car) - 1;
        for ($i = 0; $i < 12; $i++) {
            $index = rand(0, $length);
            $mdp .= $car[$index];
        }
        return $mdp;
    }

    if (isset($_POST['generer'])) {
        $new_mdp = GenereMdp();
        $sql = $bdd->prepare("UPDATE employe SET mdp_emp = PASSWORD(?) WHERE matricule_emp = ? ;");
        $sql->bindParam(1, $new_mdp);
        $sql->bindParam(2, $employe['matricule_emp']);
        $sql ->execute();
        echo "<div class='new-mdp'><p>Voici votre nouveau mot de passe : <span> $new_mdp </span></p></div>";
    }
?>

<form method="post" class='new-mdp'>
    <input type="submit" name="generer" value="Génerer">
</form>


<?php require('../common/footer.html'); ?>