<?php
echo "<div>Atualizando dados abaixo... </div>";

require ('connec.php');
require ('sucess.php');

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $id = $_POST["id"];
    $titulo = $_POST["titulo"];
    $autor = $_POST["autor"];
    $ano_public = $_POST["ano_public"];
    echo "<div id='divisoria'>__________________________________________________________</div>";
 
    // Função para Atualizar o registro no banco de dados
    function atualizarRegistro($pdo, $id, $titulo, $autor, $ano_public) {
        $sql = "UPDATE livros SET titulo = '$titulo', autor = '$autor', ano_public = '$ano_public' WHERE id = $id";
        $stmt = $pdo->prepare($sql);
        return $stmt->execute();
    }
}
if (atualizarRegistro($pdo, $id, $titulo, $autor, $ano_public)) {
    echo "<div>Registro atualizado com sucesso!</div>" . "<div><a href='index.php'>HOME</a></div>";
} else {
    echo 'Erro ao inserir o registro.';
}
?>