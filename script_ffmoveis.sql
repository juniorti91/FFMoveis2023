-- Criar a tabela Categoria
CREATE TABLE Categoria (
    id_categoria INT IDENTITY PRIMARY KEY,
    nome_categoria VARCHAR(255) NOT NULL
);

-- Criar a tabela Subcategoria
CREATE TABLE Subcategoria (
    id_subcategoria INT IDENTITY PRIMARY KEY,
    id_categoria INT,
    nome_subcategoria VARCHAR(255) NOT NULL,
    FOREIGN KEY (id_categoria) REFERENCES Categoria (id_categoria)
);

-- Criar a tabela ItemSubcategoria
CREATE TABLE Produtos (
    id_produtos INT IDENTITY PRIMARY KEY,
    id_subcategoria INT,
    nome_produtos VARCHAR(255) NOT NULL,
    descricao_produtos TEXT,
    preco_produtos DECIMAL(10, 2),
    FOREIGN KEY (id_subcategoria) REFERENCES Subcategoria (id_subcategoria)
);

-- //////////////// CATEGORIA INSERINDO DADOS //////////////////////
insert into Categoria (nome_categoria) values ('Cozinha');
insert into Categoria (nome_categoria) values ('Quarto');
insert into Categoria (nome_categoria) values ('Sala');
insert into Categoria (nome_categoria) values ('EScritorio');


-- /////////////// SUBCATEGORIA INSERINDO DADOS ////////////////////
insert into Subcategoria (id_categoria, nome_subcategoria) values (1, 'Aereo');
insert into Subcategoria (id_categoria, nome_subcategoria) values (1, 'Balcao');
insert into Subcategoria (id_categoria, nome_subcategoria) values (1, 'Eletros');
insert into Subcategoria (id_categoria, nome_subcategoria) values (1, 'Fruteira');

-- /////////////// PRODUTOS INSERINDO DADOS ////////////////////////
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (1, 'Aereo Diva', 'Produto descritivo de parede 1', 399.98);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (1, 'Aereo Una 120', 'Produto descritivo de parede 2', 99.90);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (1, 'Aereo Tres', 'Produto descritivo de parede 3', 9.85);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (1, 'Aereo Quatro', 'Produto descritivo de parede 4', 3.00);

insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (2, 'Balcao Pre-Pia', 'Produto descritivo de balcao 1', 5.58);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (2, 'Balcao Forno', 'Produto descritivo de balcao 2', 6.30);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (2, 'Multiuso Balcao', 'Produto descritivo de balcao 3', 78.90);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (2, 'Balcao Cookto', 'Produto descritivo de balcao 4', 20.00);

insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (3, 'Sanduicheira A', 'Produto descritivo de sanduicheira 1', 40.10);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (3, 'Sanduicheira B', 'Produto descritivo de sanduicheira 2', 60.02);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (3, 'Sanduicheira C', 'Produto descritivo de sanduicheira 3', 98.65);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (3, 'Sanduicheira D', 'Produto descritivo de sanduicheira 4', 50.45);

insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (4, 'Fruteira de Cozinha', 'Produto descritivo de fruteira 1', 56.40);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (4, 'Fruteira de Parede', 'Produto descritivo de fruteira 2', 25.50);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (4, 'Fruteira de Cantos', 'Produto descritivo de fruteira 3', 45.30);
insert into Produtos (id_subcategoria, nome_produtos, descricao_produtos, preco_produtos) values (4, 'Fruteira de Balcao', 'Produto descritivo de fruteira 4', 89.90);

-- //////////////////// CONSULTAS NO BANCO ////////////////////----

SELECT 
	P.nome_produtos AS NomeItem,
	P.descricao_produtos AS Descricao, 
	P.preco_produtos AS Preco
FROM Categoria C
INNER JOIN Subcategoria SC ON C.id_categoria = SC.id_categoria
INNER JOIN Produtos P ON SC.id_subcategoria = P.id_subcategoria
WHERE C.nome_categoria = 'Cozinha' AND SC.nome_subcategoria = 'Aereo';