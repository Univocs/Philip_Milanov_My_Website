# US-12: Een betrouwbare eerste release publiceren

- **Type:** User story
- **Status:** Ready
- **Volgorde:** 13 van 13
- **Grootte:** M
- **Afhankelijkheden:** EN-01 en US-01 t/m US-11

## Story

Als Philip wil ik dat het portfolio automatisch wordt gedeployed zodat bezoekers een stabiele en actuele versie zien.

## Acceptance criteria

- Een productieomgeving voor frontend en API wordt via HTTPS gedeployed.
- De frontend gebruikt environmentconfiguratie voor de base URL van de API.
- Productie-CORS staat alleen de bedoelde frontend-origin toe.
- CI bouwt en test zowel de .NET- als React-applicatie bij pull requests.
- Een directe bezoekpoging of refresh werkt voor elke ondersteunde URL.
- De README documenteert de live-URL, lokale setup, configuratie en deploymentprocedure.
- Er worden geen secrets of persoonsgegevens gecommit naar de repository of uitgevoerd naar de browserconsole.


