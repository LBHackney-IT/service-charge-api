.PHONY: setup
setup:
	docker-compose build

.PHONY: build
build:
	docker-compose run service-charge-api dotnet build

.PHONY: serve
serve:
	docker-compose up service-charge-api

.PHONY: shell
shell:
	docker-compose run service-charge-api bash

.PHONY: test
test:
	docker-compose build service-charge-api-test && docker-compose up service-charge-api-test
