<?php 
    require('../common/header.html');
    require('../login.php');
    include('../common/navBar.php');
    include('../model/connexionBDD.php');

    $matricule_emp = $_SESSION['matricule_emp'];

    $sql = $bdd->prepare("SELECT * FROM employe INNER JOIN etat ON employe.matricule_emp = etat.matricule_emp WHERE employe.matricule_emp = ?");
    $sql->bindParam(1, $matricule_emp);
    $sql->execute();
    $employe = $sql->fetch();

    $cp_acquis = $employe['cp_acquis'];
    $rtt_acquis = $employe['rtt_acquis'];
    $cp_restant = $employe['cp_restant'];
    $rtt_restant = $employe['rtt_restant'];
?>

<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>

<div class='graph-stat'>
    <div>
        <div class='graph-acquis'>
            <canvas id="Graph1"></canvas>
        </div>
        <script>
            var ctxt = document.getElementById('Graph1').getContext('2d');
            var Graph1 = new Chart(ctxt, {
                type: 'doughnut',
                data: {
                    labels: ['Congés payés acquis', 'RTT acquis'],
                    datasets: [{
                        label: 'Congés acquis',
                        data: [<?php echo $cp_acquis; ?>, <?php echo $rtt_acquis; ?>],
                        backgroundColor: [
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(54, 162, 235, 0.2)'],
                        borderColor: [
                            'rgba(255, 99, 132, 1)',
                            'rgba(54, 162, 235, 1)'],
                        borderWidth: 1
                    }]
                },
            });
        </script>
    </div>
    <div>
        <div class='graph-restant'>
            <canvas id="Graph2"></canvas>
        </div>
        <script>
            var ctxt = document.getElementById('Graph2').getContext('2d');
            var Graph2 = new Chart(ctxt, {
                type: 'doughnut',
                data: {
                    labels: ['Congés payés restants', 'RTT restants'],
                    datasets: [{
                        label: 'Congés restants',
                        data: [<?php echo $cp_restant; ?>, <?php echo $rtt_restant; ?>],
                        backgroundColor: [
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(54, 162, 235, 0.2)'],
                        borderColor: [
                            'rgba(255, 99, 132, 1)',
                            'rgba(54, 162, 235, 1)'],
                        borderWidth: 1 
                    }]
                },
            });
        </script>
    </div>
</div>

<?php require('../common/footer.html'); ?>
