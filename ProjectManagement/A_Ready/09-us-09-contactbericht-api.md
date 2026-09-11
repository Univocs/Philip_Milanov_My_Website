# US-09: Veilig een contactbericht ontvangen

- **Type:** User story
- **Status:** Ready
- **Volgorde:** 10 van 13
- **Grootte:** M
- **Afhankelijkheden:** EN-01

## Story

Als geïnteresseerde bezoeker wil ik Philip een bericht kunnen sturen zodat ik een gesprek kan starten.

## Acceptance criteria

- De API biedt een publieke `POST /contact-messages`-endpoint die naam, e-mail en bericht accepteert.
- Verplichte velden, een geldige e-mailstructuur en redelijke maximale lengtes worden op de server gevalideerd.
- Een geldig request slaat het bericht op en retourneert `201 Created` zonder interne details terug te geven.
- Een ongeldig request retourneert `400 Bad Request` met bruikbare fouten per veld.
- Integratietests dekken een geldige submission en representatieve ongeldige submissions af.
- De bestaande endpoint om berichten op te vragen wordt niet publiek beschikbaar gemaakt zonder authorization.

## Security-opmerking

Contactberichten lezen is een adminmogelijkheid; een bericht indienen is een publieke mogelijkheid.


