<p>Desafio pr&aacute;tico de Programa&ccedil;&atilde;o - Autoglass</p>
<p><br></p>
<p>O que desenvolver?</p>
<p>Voc&ecirc; ir&aacute; criar API para a gest&atilde;o de produtos, com os seguintes recursos:</p>
<ul>
    <li>&nbsp;Recuperar um registro por c&oacute;digo;<ul>
            <li>Listar registros Filtrando a partir de par&acirc;metros e paginando a resposta</li>
        </ul>
    </li>
    <li>Inserir<ul>
            <li>Criar valida&ccedil;&atilde;o para o campo data de fabrica&ccedil;&atilde;o que n&atilde;o poder&aacute; ser maior ou igual a data de validade.</li>
        </ul>
    </li>
    <li>Editar<ul>
            <li>Criar valida&ccedil;&atilde;o para o campo data de fabrica&ccedil;&atilde;o que n&atilde;o poder&aacute; ser maior ou igual adata de validade.</li>
        </ul>
    </li>
    <li>Excluir<ul>
            <li>A exclus&atilde;o dever&aacute; ser l&oacute;gica, atualizando o campo situa&ccedil;&atilde;o com o valor Inativo.</li>
        </ul>
    </li>
</ul>
<p><br></p>
<p>Campos no escopo de produtos s&atilde;o</p>
<p>C&oacute;digo do produto (sequencial e n&atilde;o nulo)</p>
<p>Descri&ccedil;&atilde;o do produto (n&atilde;o nulo)</p>
<p>Situa&ccedil;&atilde;o do produto (Ativo ou Inativo)</p>
<p>Data de fabrica&ccedil;&atilde;o</p>
<p>Data de validade</p>
<p>C&oacute;digo do fornecedor</p>
<p>Descri&ccedil;&atilde;o do fornecedor</p>
<p>CNPJ do fornecedor</p>
<p><br></p>
<p>Requisitos Obrigat&oacute;rio</p>
<ul>
    <li>Construir a Web-api em dotnet core ou dotnet 5.</li>
    <li>Construir a estrutura em camadas e em DDD.</li>
</ul>
<p>Diferenciais</p>
<ul>
    <li>Utilizar ORM</li>
    <li>&nbsp;Utilizar a biblioteca Automapper para fazer o mapeamento entity-DTO.</li>
    <li>&nbsp;Fazer teste unit&aacute;rios</li>
</ul>
