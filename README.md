# RedisSentinelPoco

1. Build docker image
```cmd
docker compose -f docker-compose.yml build
```

1. Run application
```cmd
docker compose -f docker-compose.yml up -d
```

2. Go to Docker (Desktop)
Container ```redis-clinet-``` should have run to complition with exit code 0. ```It works!``` event should exist in the log.
