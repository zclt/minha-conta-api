CREATE TABLE lancamentos (
    id SERIAL PRIMARY KEY,
    user_id VARCHAR(36) NOT NULL,
    external_id VARCHAR(36) NOT NULL,
    descricao VARCHAR(200) NOT NULL,
    valor DECIMAL(10,2) NOT NULL,
    data DATE NOT NULL
);

-- Índices recomendados para performance
CREATE INDEX idx_lancamentos_user_id ON lancamentos(user_id);
CREATE INDEX idx_lancamentos_data ON lancamentos(data);
CREATE UNIQUE INDEX idx_lancamentos_external_id ON lancamentos(external_id);