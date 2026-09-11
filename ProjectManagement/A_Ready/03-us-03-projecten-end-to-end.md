# US-03: Echte projecten end-to-end bekijken

- **Type:** User story
- **Status:** Ready
- **Volgorde:** 4 van 13
- **Grootte:** M
- **Afhankelijkheden:** EN-01 en US-01

## Story

Als bezoeker wil ik Philips projecten bekijken zodat ik de kwaliteit en veelzijdigheid van zijn werk kan beoordelen.

## Acceptance criteria

- De API retourneert minstens drie representatieve *geseede* projecten volgens `DisplayOrder`.
- Elke projectresponse bevat de informatie die de kaart daadwerkelijk nodig heeft: titel, korte beschrijving, herbruikbare tags en een optionele bestemmings-URL.
- De frontend haalt projecten op via `/projects`, de projectlijst wordt niet opnieuw hardcoded in de component.
- Een projectkaart toont titel, beschrijving en tags en opent veilig een geldige bestemming wanneer die beschikbaar is.
- Loading-, empty- en failure-states zijn zichtbaar en begrijpelijk.
- Een API-integratietest verifieert ordering en mapping, en een frontendtest verifieert minstens de success- en failure-states.

## Implementatietip

Dit is de walking skeleton. Werk deze volledig af over API en React voordat je de andere contentsecties bouwt.


