namespace EnumPractice_1;

/**
 * * Source: https://www.c-sharpcorner.com/article/how-i-use-enums-in-my-practice/
 */

// Scenario: WebApp Request Type
public enum RequestType : byte
{
    HttpPost = 1,
    HttpGet = 2,
    HttpPut = 3,
}

// Scenario: Following transactions through the payment gateway
public enum RecieptType : byte
{
    Customer_CreditCode_Credit = 1,
    Customer_Contact_Credit = 2,
    Customer_Debit = 3
}

// Scenario: if the response from the banking service was 1, the user was found; otherwise, if it was 0
public enum XBankResponse
{
    Customer_Found = 1,
    Customer_Not_Found = 0
}

// Scenario: Course Types
public enum CourseType
{
    VideoCourse,
    Online,
    Offline
}

// Scenario: Logging Operation Type
public enum LogOperation : byte
{
    Inserted = 1,
    Updated = 1,
    Deleted = 3,
}

// Scenario: Database Operation Type
public enum ActionType
{
    Delete = 2,
    Update = 1,
    Insert = 0
}

// Scenario: if smeone wants to know Meal plans
public enum MealType
{
    Breakfast = 1,
    Lunch = 2,
    Dinner = 3
}

// Scenario: If a journalist want to participate in a competition
public enum MediaStatusType : byte
{
    Investigating = 1,
    Rejected = 2,
    Accepted = 3
}

// Scenario: Role system structure with an enum
public enum RoleType : byte
{
    SuperAdmin = 1 << 6,
    UEG = 1 << 5,
    LOC = 1 << 4,
    NF = 1 << 3,
    Group = 1 << 2,
    Individual = 1,
    Media = 1,
    MediaManager = 4,
    Observer = 2
}

// Scenario: Status of the Card
public enum CardStatus
{
    Active = 1,
    Deactive = 2
}

// Scenario: Ticket Status
public enum IncidentStatus
{
    Open = 1,
    InProcess = 2,
    Close = 3
}