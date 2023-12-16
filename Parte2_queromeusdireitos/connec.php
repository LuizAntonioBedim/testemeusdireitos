<?php
$host = 'localhost';
$dbname = 'testemeusdireitos';
$username = 'root';
$password = '';
try {
    $pdo = new PDO("mysql:host=$host;dbname=$dbname", $username, $password);
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    #echo "Connected successfully";
} catch (PDOException $e) {
    die("Falha na conecxão: " . $e->getMessage());
}
?>