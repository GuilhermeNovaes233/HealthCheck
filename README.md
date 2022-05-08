# HealthCheck

O que é Health Checks ?
O Health Checks nada mais é que um middleware que nos fornece um endpoint configurável que retorna o estado atual da aplicação.

Rota para visualizar HealthCheck
    
    https://localhost:5001/health

Visualizar eventos e históricos via dashboard
    
    localhost:5001/dashboard

Projeto baseado no Artigo do Balta.io: https://balta.io/blog/aspnet-health-check


Alguns pacotes interessantes do Health Check

    SQL Server (AspNetCore.HealthChecks.SqlServer)
    RabbitMQ (AspNetCore.HealthChecks.RabbitMQ)
    Elasticsearch (AspNetCore.HealthChecks.Elasticsearch)
    Redis (AspNetCore.HealthChecks.Redis)
    Amazon DynamoDb (AspNetCore.HealthChecks.DynamoDB)
    mazon S3 (AspNetCore.HealthChecks.Aws.S3)

Links Úteis

    https://medium.com/swlh/how-to-implement-healthcheck-api-in-microservices-architecture-with-net-core-a5882369b016

    https://testfully.io/blog/api-health-check-monitoring/
