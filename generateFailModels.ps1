#Invoke-WebRequest https://raw.githubusercontent.com/shopware/store-api-reference/main/storeapi.json -UseBasicParsing -OutFile .\openapi\storeapi.json

docker run --rm -v ${PWD}:/local openapitools/openapi-generator-cli generate -i /local/openapi/storeapi.json -g csharp -o /local --global-property models=data --additional-properties=packageName=ShopwareSharp