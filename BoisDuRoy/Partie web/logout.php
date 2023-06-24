<?php
    session_start();
    $_SESSION = array() ;
    session_destroy(); // On détruit la session
    header('Location:index.php');
?>