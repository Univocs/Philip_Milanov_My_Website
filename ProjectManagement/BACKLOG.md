# Backlog persoonlijke website

## Minimal Viable Product
> Zie [Sprint 1](sprint-01.md).

## Sprint 2 
> Contentbeheer nadat de MVP live staat

Begin hier niet aan voordat US-01 tot en met US-12 zijn geaccepteerd.

Archiveer de user stories uit `sprint-01.md`.

**Daarna:**

Creëer `sprint-02.md`.
US-13 tot en met US-17, opgesplitst in kleinere stories tijdens refinement. Op dit punt kan content veilig worden beheerd zonder opnieuw te moeten deployen.

### [ ] US-13: Aanmelden als eigenaar van de website (M)

**Story:** Als eigenaar van de website wil ik mij authenticeren zodat alleen ik portfoliocontent kan wijzigen of berichten kan lezen.

**Acceptance criteria**

* Er is geen publieke registratieflow; het account van de eigenaar wordt bewust geprovisioneerd.

* Wachtwoorden worden verwerkt door een standaard identity-/authenticationlibrary en worden nooit als gewone tekst opgeslagen of gelogd.

* Protected endpoints retourneren `401` wanneer de gebruiker niet geauthenticeerd is en `403` wanneer hij niet geautoriseerd is.

* Authenticationconfiguratie en secrets komen uit environmentspecifieke configuratie.

* Geautomatiseerde tests bewijzen dat admindata niet anoniem toegankelijk is.


### [ ] US-14: Portfoliodata persistent opslaan (L; splitsen voordat je begint)

**Story:** Als eigenaar van de website wil ik dat content en berichten herstarts overleven zodat de live website betrouwbaar is.

**Acceptance criteria**

* Projecten, tags, skillgroepen, carrière-items, verwezenlijkingen, gebruikers en berichten worden opgeslagen in een ondersteunde database.

* Wijzigingen aan het databaseschema worden weergegeven als migrations.

* Een herhaalbare seed levert development-/democontent zonder dubbele records te creëren.

* Repositorygedrag blijft slagen in integratietests tegen een geïsoleerde testdatabase.

* De deployment bevat een gedocumenteerde aanpak voor backups en migrations.

**Voorgestelde opsplitsing:** databasefundament en migrations; migratie van read models; persistentie van contactberichten; productie-migrationprocedure.


### [ ] US-15: Projecten en herbruikbare tags beheren (L; splitsen voordat je begint)

**Story:** Als eigenaar van de website wil ik projecten en tags kunnen toevoegen, wijzigen, ordenen en verwijderen zodat het portfolio actueel blijft zonder codewijziging.

**Acceptance criteria**

* Geauthenticeerde API-operaties en een admin-UI ondersteunen create, edit, reorder en delete.

* Een tag kan door meerdere projecten worden hergebruikt zonder onbedoelde duplicatie.

* Destructieve acties vereisen bevestiging en geven duidelijke feedback bij succes of falen.

* Ongeldige of conflicterende updates beschadigen bestaande content niet.

* Het publieke projectgedrag uit US-03 en US-04 blijft getest.


### [ ] US-16: Carrière en vaardigheden beheren (L; splitsen voordat je begint)

**Story:** Als eigenaar van de website wil ik carrièreverwezenlijkingen en gegroepeerde vaardigheden kunnen beheren zodat de publieke informatie correct blijft.

**Acceptance criteria**

* Geauthenticeerde adminschermen ondersteunen create, edit, reorder en delete voor beide gebieden.

* Wijzigingen aan parent-/childrelaties laten geen verweesde achievements of skills achter.

* Validatieregels sluiten aan bij de daadwerkelijke noden van de publieke weergave.

* Publiek gedrag voor carrière en vaardigheden blijft getest.


### [ ] US-17: Contactberichten bekijken en verwijderen (M)

**Story:** Als eigenaar van de website wil ik contactberichten bekijken en verwijderen zodat ik kan antwoorden en opgeslagen persoonsgegevens kan beheren.

**Acceptance criteria**

* Alleen een geauthenticeerde eigenaar kan berichten oplijsten, lezen of verwijderen.

* De lijst toont afzender, verzendtijd en gelezen/ongelezen-status zonder berichten publiek beschikbaar te maken.

* Verwijderen vereist bevestiging.

* Er wordt een bewaarbeleid gedocumenteerd dat gevolgd kan worden.

* Authorization- en deletegedrag worden geautomatiseerd getest.

## Sprint 3

Deze ideeën uit de mock-up vereisen bewijs of een korte spike voordat ze worden geïmplementeerd.

### [ ] SP-01: Een mediastrategie kiezen (S, time-boxed onderzoek)

Beslis waar thumbnails, video's, de showreel en downloadbare bestanden worden opgeslagen; documenteer limieten voor bestandsgrootte, ondersteunde formaten, kosten, accessibilityvereisten en hoe de API ernaar verwijst. Het resultaat is een korte decision record, geen mediaplatform.

### [ ] US-18: Een showreel afspelen (M)

Als bezoeker wil ik een showreel kunnen afspelen met controls, ondertiteling/transcript, een posterafbeelding en een fallbacklink. Implementeer dit alleen na SP-01 en nadat echte media beschikbaar zijn.

### [ ] SP-02: De geanimeerde “Ask me”-assistent valideren (S, time-boxed prototype)

Test of bezoekers het geanimeerde personage begrijpen en gebruiken, welke vragen het kan beantwoorden, welke service ervoor nodig is en welke privacy-, kosten- en accessibilityrisico's het introduceert. Introduceer geen chatinfrastructuur voordat het prototype een duidelijke meerwaarde heeft aangetoond.

### [ ] US-19: Doelgerichte visuele beweging toevoegen (S)

Voeg transitions of het gedrag waarbij de bovenste navigatie naar de zijkant beweegt alleen toe wanneer dit de oriëntatie verbetert. Beweging mag interactie niet blokkeren en moet `prefers-reduced-motion` respecteren.

### [ ] US-20: Social links en sharingmetadata toevoegen (S)

Voeg goedgekeurde sociale links, favicon, paginatitel, description en social-previewmetadata toe. Elke externe link moet actueel en bewust publiek zijn.


## Expliciet niet in de eerste release

* Publieke accountregistratie of meerdere adminrollen.

* Een zelfgebouwde wachtwoord-/authenticationimplementatie.

* Volledige CRUD voordat de publieke read experience nuttig is.

* Een chatbot, AI-integratie of geanimeerd interactief personage.

* Zelfgebouwde carrouselmechanismen of navigatie die tijdens het scrollen van positie verandert.

* Premature clouduploads van media, analytics, e-mailcampagnes of een general-purpose CMS.

Deze ideeën worden niet verworpen; ze worden bewust beschermd tegen het risico dat ze afleiden voordat het kernportfolio goed werkt.
