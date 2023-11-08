CREATE TABLE Produto (
    idProduto SERIAL NOT NULL PRIMARY KEY,
    nomeProduto VARCHAR(255) NOT NULL,
    categoria VARCHAR(255), /*Cura, efeitos, ...*/
    descricao TEXT NOT NULL,
    data DATE NOT NULL,
    validade DATE NOT NULL,
    disponivel BOOLEAN NOT NULL,
    qtnd INT NOT NULL, /*quantidade*/
    preco DECIMAL(10,2) NOT NULL,
    fornecedor SERIAL NOT NULL ON DELETE CASCADE,

    FOREIGN KEY (fornecedor) REFERENCES Fornecedor(idFornecedor)
);

CREATE TABLE Fornecedor (
    idFornecedor SERIAL NOT NULL PRIMARY KEY,
    nomeFornecedor VARCHAR(255) NOT NULL,
    telefone VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    endereco VARCHAR(255) NOT NULL
);