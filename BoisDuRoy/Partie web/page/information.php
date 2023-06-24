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

    function conges_dmd_info($bdd, $matricule_emp) {
        $cmd = $bdd->prepare("SELECT * FROM employe INNER JOIN demande ON demande.matricule_emp = employe.matricule_emp INNER JOIN statut ON demande.id_statut = statut.id_statut WHERE employe.matricule_emp = ? AND nom_statut = 'En cours' ;");
        $cmd->bindParam(1, $matricule_emp);
        $cmd->execute();
        $result = $cmd->fetchall(PDO::FETCH_ASSOC);
        return $result;
    }
    $conge_dmd = conges_dmd_info($bdd, $matricule_emp);

    function conges_vld_info($bdd, $matricule_emp) {
        $cmd = $bdd->prepare("SELECT * FROM employe INNER JOIN demande ON demande.matricule_emp = employe.matricule_emp INNER JOIN statut ON demande.id_statut = statut.id_statut WHERE employe.matricule_emp = ? AND nom_statut = 'Validé' ;");
        $cmd->bindParam(1, $matricule_emp);
        $cmd->execute();
        $result = $cmd->fetchall(PDO::FETCH_ASSOC);
        return $result;
    }
    $conge_vld = conges_vld_info($bdd, $matricule_emp);

    function conges_rfs_info($bdd, $matricule_emp) {
        $cmd = $bdd->prepare("SELECT * FROM employe INNER JOIN demande ON demande.matricule_emp = employe.matricule_emp INNER JOIN statut ON demande.id_statut = statut.id_statut WHERE employe.matricule_emp = ? AND nom_statut = 'Refusé' ;");
        $cmd->bindParam(1, $matricule_emp);
        $cmd->execute();
        $result = $cmd->fetchall(PDO::FETCH_ASSOC);
        return $result;
    }
    $conge_rfs = conges_rfs_info($bdd, $matricule_emp);
?>
    <div class='contain-info'>
        <div class='info-pers'>
            <p><span class='info-label'>Nom : </span><?php echo $employe['nom_emp'] ?></p>
            <p><span class='info-label'>Prénom : </span><?php echo $employe['prenom_emp'] ?></p>
            <p><span class='info-label'>Matricule : </span><?php echo $employe['matricule_emp'] ?></p>
            <p><span class='info-label'>Service : </span><?php echo $employe['nom_service'] ?></p>
            <p><span class='info-label'>Fonction : </span><?php echo $employe['nom_fonction'] ?></p>
            <p><span class='info-label'>Date d'embauche: </span><?php echo $employe['date_emb_emp'] ?></p>
            <p><span class='info-label'>Date de naissance : </span><?php echo $employe['date_naiss_emp'] ?></p>
            <p><span class='info-label'>Numéro de sécurité sociale : </span><?php echo $employe['num_secu_emp'] ?></p>
            <p><span class='info-label'>Congés payés acquis : </span><?php echo $employe['cp_acquis'] ?></p>
            <p><span class='info-label'>Congés payés restants : </span><?php echo $employe['cp_restant'] ?></p>
            <p><span class='info-label'>RTT acquis : </span><?php echo $employe['rtt_acquis'] ?></p>
            <p><span class='info-label'>RTT restants : </span><?php echo $employe['rtt_restant'] ?></p>
        </div>

        <div class='conge'>
            <div class='sub-conge'>
                <h3>Congés demandés</h3>
                <?php  
                foreach($conge_dmd as $periode){
                    echo '<p>Du '.$periode['date_debut'].' au '.$periode['date_fin'].'</p>';
                } ?>
            </div>

            <div class='sub-conge'>
                <h3>Congés validés</h3>
                <?php foreach($conge_vld as $periode){
                    echo '<p>Du '.$periode['date_debut'].' au '.$periode['date_fin'].'</p>';
                } ?>
            </div>

            <div class='sub-conge'>
                <h3>Congés refusés</h3>
                    <?php foreach($conge_rfs as $periode){
                    echo '<p>Du '.$periode['date_debut'].' au '.$periode['date_fin'].'</p>';
                    } ?>
            </div>
        </div>

    </div>


<?php require('../common/footer.html'); ?>