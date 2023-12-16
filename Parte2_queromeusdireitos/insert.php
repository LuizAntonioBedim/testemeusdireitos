<?php
echo "<div>Inserindo dados abaixo... </div>";
echo "<div> </div>";
require ('connec.php');
require ('sucess.php');

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    echo '<div>' . $titulo = $_POST["titulo"] . '</div>';
    echo '<div>' . $autor = $_POST["autor"] . '</div>';
    $ano_public = $_POST["ano_public"];
    echo "<div id='divisoria'>__________________________________________________________</div>";

    // Função para inserir um novo registro no banco de dados
    function inserirRegistro($pdo, $titulo, $autor, $ano_public) {
        $sql = "INSERT INTO livros (titulo, autor, ano_public) VALUES (:titulo, :autor, :ano_public)";
        $stmt = $pdo->prepare($sql);
        $stmt->bindParam(':titulo', $titulo, PDO::PARAM_STR);
        $stmt->bindParam(':autor', $autor, PDO::PARAM_STR);
        $stmt->bindParam(':ano_public', $ano_public, PDO::PARAM_STR);
        return $stmt->execute();
    }
}
if (inserirRegistro($pdo, $titulo, $autor, $ano_public)) {
    echo "<div>Registro inserido com sucesso!</div>" . "<div><a href='index.php'>HOME</a></div>";
} else {
    echo 'Erro ao inserir o registro.';
}
?>