#Invoke-WebRequest https://raw.githubusercontent.com/shopware/store-api-reference/main/storeapi.json -UseBasicParsing -OutFile .\openapi\storeapi.json

docker run --rm -v ${PWD}:/local openapitools/openapi-generator-cli generate -i /local/openapi/storeapi.json -g csharp-netcore -o /local -c /local/openapi/config.yaml --ignore-file-override=/local/.openapi-generator-ignore