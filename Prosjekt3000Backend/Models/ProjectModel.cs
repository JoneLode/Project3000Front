using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Prosjekt3000Backend.Models;

public class ProjectModel
{
    /*
    •	Metadata om hvert prosjekt
    o	Prosjektnavn
    o	Deltakere fra SG
    o	Oppdragsgiver
    	Navn
    	Avdeling
        o	Kontaktpersoner
        o	Beskrivelse av prosjekt
        o	Status på prosjekt (avsluttet, under planlegging, pågående, etc)
    o	Estimert varighet (timer?)
    o	Forbrukt timer
        o	Oppstartsdato
        o	Avsluttet dato
    o	Benyttet techstack (inkl versjoner?)
    o	Referanse til GitLab
    o	Gradering (hvis mulig)
    o	Nøkkelleveranse
    o	Læringspunkter
    o	Retrospektive
    */
    
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string Name { get; set; }
    public List<string> Participants { get; set; }

}