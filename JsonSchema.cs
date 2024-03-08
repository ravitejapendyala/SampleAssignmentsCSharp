using System;
using System.Collections.Generic;
using System.Security.AccessControl;

public class Meta
{
    public DateTime lastUpdated { get; set; }
    public string source { get; set; }
    public List<string> profile { get; set; }
}

public class Identifier
{
    public string use { get; set; }
    public string system { get; set; }
    public string value { get; set; }
}

public class Coding
{
    public string system { get; set; }
    public string code { get; set; }
    public string display { get; set; }
}

public class MedicationCodeableConcept
{
    public List<Coding> coding { get; set; }
}

public class Reference
{
    public string reference { get; set; }
    public string type { get; set; }
}

public class ReasonCode
{
    public List<Coding> coding { get; set; }
}

public class DoseQuantity
{
    public int value { get; set; }
    public string unit { get; set; }
    public string system { get; set; }
    public string code { get; set; }
}

public class DoseAndRate
{
    public DoseQuantity doseQuantity { get; set; }
}

public class DosageInstruction
{
    public string text { get; set; }
    public string patientInstruction { get; set; }
    public bool asNeededBoolean { get; set; }
    public List<DoseAndRate> doseAndRate { get; set; }
}

public class ValidityPeriod
{
    public DateTime start { get; set; }
    public DateTime end { get; set; }
}

public class Quantity
{
    public int value { get; set; }
    public string unit { get; set; }
    public string system { get; set; }
    public string code { get; set; }
}

public class DispenseRequest
{
    public ValidityPeriod validityPeriod { get; set; }
    public int numberOfRepeatsAllowed { get; set; }
    public Quantity quantity { get; set; }
}

public class Substitution
{
    public bool allowedBoolean { get; set; }
}

public class Resource
{
    public string resourceType { get; set; }
    public string id { get; set; }
    public Meta meta { get; set; }
    public List<Identifier> identifier { get; set; }
    public string status { get; set; }
    public string intent { get; set; }
    public string priority { get; set; }
    public bool reportedBoolean { get; set; }
    public MedicationCodeableConcept medicationCodeableConcept { get; set; }
    public Reference subject { get; set; }
    public DateTime authoredOn { get; set; }
    public Reference requester { get; set; }
    public List<ReasonCode> reasonCode { get; set; }
    public List<object> note { get; set; }
    public List<DosageInstruction> dosageInstruction { get; set; }
    public DispenseRequest dispenseRequest { get; set; }
    public Substitution substitution { get; set; }
}

public class Entry
{
    public string fullUrl { get; set; }
    public Resource resource { get; set; }
}

public class MyJsonSchema
{
    public string resourceType { get; set; }
    public string type { get; set; }
    public DateTime timestamp { get; set; }
    public List<Entry> entry { get; set; }
}



    internal class JsonTest
    {
        [Test]
        public void JsonToString()
        {
            //Meta meta = new Meta();
        //Identifier identifier = new Identifier();
        MyJsonSchema jsonObj = new MyJsonSchema
        {
            resourceType = "Bundle",
            type = "collection",
            timestamp = DateTime.Now,
            entry = new List<Entry>
            {
                new Entry
                {
                    fullUrl = "urn:uuid:a3f87d17-dd1c-42a1-94e4-fe5333a0f999",
                    resource = new Resource
                    {
                        resourceType="MedicationRequest",
                        id="a3f87d17-dd1c-42a1-94e4-fe5333a0f999",
                        meta = new Meta
                        {
                            lastUpdated=DateTime.Now,
                            source="SIPTestExtension#1.0.0",
                            profile = new List<string>
        {
            "http://fhir.phreesia.net/integration-api/StructureDefinition/IntegrationMedicationRequest"
        }
                        },
                        identifier = new List<Identifier>
                        {
                            new Identifier
                            {
                                use = "official",
                                system = "Integration.Example.ID",
                                value = "a3f87d17-dd1c-42a1-94e4-fe5333a0f999"
                            }
                        },
                        status = "active",
                        intent="order",
                        priority="routine",
                        reportedBoolean=false,
                        medicationCodeableConcept = new MedicationCodeableConcept
                        {
                            coding = new List<Coding>
                            {
                                new Coding
                                {
                                    system = "http://hl7.org/fhir/sid/ndc",
                                    code = "00078063968",
                                    display = "Repatha"
                                }
                            }
                        },
                        
                        subject = new Reference
                        {
                            reference = "Patient/8e6fa5b0-c69a-11ee-a172-005056b46200",
                            type = "Patient"
                        },                        
                        authoredOn = DateTime.Parse("2022-09-22T14:41:25+00:00"),
                        requester = new Reference
                        {
                            reference = "Practitioner/5017c3ed-1945-11ed-b289-0a0a32995bbe",
                            type = "Practitioner"
                        },
                        reasonCode = new List<ReasonCode>
                        {
                            new ReasonCode
                            {
                                coding = new List<Coding>
                                {
                                    new Coding
                                    {
                                        system = "http://snomed.info/sct",
                                        code = "40930008",
                                        display = "Hypothyroidism (disorder)"
                                    }
                                }
                            }
                        },
                        note = new List<object>
                        {
                            new { text = "Patient indicates they miss the occasional dose" }
                        },
                        dosageInstruction = new List<DosageInstruction>
                        {
                            new DosageInstruction
                            {
                                text = "50 mg, 1 tab, Oral, Daily, 20 tab, 1 Refill(s)",
                                patientInstruction = "Do not take pain killers or multi-vitamins upto 4 hours of taking this medication",
                                asNeededBoolean = false,
                                doseAndRate = new List<DoseAndRate>
                                {
                                    new DoseAndRate
                                    {
                                        doseQuantity = new DoseQuantity
                                        {
                                            value = 1,
                                            unit = "tablet",
                                            system = "http://unitsofmeasure.org",
                                            code = "{tbl}"
                                        }
                                    }
                                }
                            }
                        },
                        dispenseRequest = new DispenseRequest
                        {
                            validityPeriod = new ValidityPeriod
                            {
                                start = DateTime.Parse("2024-02-08T00:00:00-05:00"),
                                end = DateTime.Parse("2024-06-30T00:00:00-05:00")
                            },
                            numberOfRepeatsAllowed = 1,
                            quantity = new Quantity
                            {
                                value = 20,
                                unit = "tablet",
                                system = "http://unitsofmeasure.org",
                                code = "{tbl}"
                            }
                        },
                        substitution = new Substitution
                        {
                            allowedBoolean = false
                        }
                    }
                }
            }
         };

            // Serialize the object to JSON string
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj);

            // Print the JSON string
            Console.WriteLine(jsonString);
        }
       
    }
