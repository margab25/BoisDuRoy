<?php 
    require('../common/header.html');
    include('../common/navBar.php');
    require('../login.php');

    function employe_info($bdd, $matricule_emp) {
        $cmd = $bdd->prepare("SELECT * FROM employe INNER JOIN service ON employe.id_service = service.id_service INNER JOIN fonction ON employe.id_fonction = fonction.id_fonction INNER JOIN etat ON employe.matricule_emp = etat.matricule_emp WHERE employe.matricule_emp = ? ;");
        $cmd->bindParam(1, $matricule_emp);
        $cmd->execute();
        $result = $cmd->fetch(PDO::FETCH_ASSOC);
        return $result;
    }

    //vérifier la différence de journée de travail
    function getDayDifference($date1, $date2) {
        $timestamp1 = strtotime($date1);
        $timestamp2 = strtotime($date2);
    
        $difference_in_seconds = abs($timestamp2 - $timestamp1);
        $difference_in_hours = $difference_in_seconds / 3600;
    
        $days_difference = floor($difference_in_hours / 24);
    
        if ($days_difference == 0 && $difference_in_hours >= 7) {
            return 1;
        } elseif ($days_difference == 0) {
            return 0.5;
        } else {
            return $days_difference;
        }
    }

    //vérification des données entrée dans le formulaire
    function verification($employe){
        //vérifier si les champs ont bien été saisie
        if(!isset($_POST['date_debut']) || !isset($_POST['date_fin']) || !isset($_POST['nb_cp']) || !isset($_POST['nb_rtt'])){
            echo "<p class='erreur-demande'>Veuillez remplir tous les champs correctement.</p>";
            return false;
        }
        //vérifier si il a assez de congé payé pour faire sa demande
        if($_POST['nb_cp'] > $employe['cp_restant'] || $_POST['nb_rtt'] > $employe['rtt_restant']){
            echo "<p class='erreur-demande'>Vous n'avez pas un nombre de congé illimité</p>";
            return false;
        }
        //vérifier que la date de fin de congé est moins récente que celle du début du congé
        if(strtotime($_POST['date_fin']) < strtotime($_POST['date_debut'])){
            echo "<p class='erreur-demande'>Veuillez vérifier que la date de début sois la plus récente</p>";
            return false;
        }

        $days_difference = getDayDifference($_POST['date_fin'], $_POST['date_debut']);

        if($days_difference != $_POST['nb_cp'] + $_POST['nb_rtt']){
            echo "<p class='erreur-demande'>Vous n'utiliser pas le bon nombre de congé (1 congé = 1 cp ou rtt)</p>";
            return false;
        }

        return true;
    }

    $matricule_emp = $_SESSION['matricule_emp'];
    $employe = employe_info($bdd, $matricule_emp);
?>

    <form method="post" action="" class ='formulaire-demande' >
        <div class='demande-form'>
            <div class="group">
                <input type="datetime-local" class="form-control" id="date_debut" name="date_debut" required>
                <label for="date_debut" class='date-label'>Date de début :</label>
            </div>

            <div class="group">
                <input type="datetime-local" class="form-control" id="date_fin" name="date_fin" required>
                <label for="date_fin" class='date-label'>Date de fin :</label>
            </div>

            <div class="group">
                <input type="number" class="form-control" id="nb_cp" name="nb_cp" min="0" max="99" required step = 0.5>
                <span class="highlight"></span>
                <span class="bar"></span>
                <label for="nb_cp">Nombre de congés payés :</label>
            </div>

            <div class="group">
                <input type="number" class="form-control" id="nb_rtt" name="nb_rtt" min="0" max="99" required step = 0.5>
                <span class="highlight"></span>
                <span class="bar"></span>
                <label for="nb_rtt">Nombre de RTT :</label>
            </div>

            <?php

            if(isset($_POST['date_debut']) && isset($_POST['date_fin']) && isset($_POST['nb_cp']) && isset($_POST['nb_rtt'])){

                if(verification($employe)){
                    $date_debut = $_POST['date_debut'];
                    $date_fin = $_POST['date_fin'];
                    $nb_cp = $_POST['nb_cp'];
                    $nb_rtt = $_POST['nb_rtt'];
                    $date = date("Y-m-d");
            
                    $cmd = $bdd->prepare("INSERT INTO demande (matricule_emp, date_debut, date_fin, nb_cp, nb_rtt, date_envoi, id_statut) VALUES (?, ?, ?, ?, ?, ?, 3) ;");
                    $cmd->bindParam(1, $employe['matricule_emp']);
                    $cmd->bindParam(2, $date_debut);
                    $cmd->bindParam(3, $date_fin);
                    $cmd->bindParam(4, $nb_cp);
                    $cmd->bindParam(5, $nb_rtt);
                    $cmd->bindParam(6, $date);
                    $cmd->execute();
                    echo "<p class='succes-demande'>Demande effectué avec succès !</p>";
                }
            }
            ?>
        </div>
        <div class='demande-button'>
            <button type="submit" >Envoyer</button>
            <button type="button" onclick="window.print()">Imprimer</button>
        </div>
    </form>

