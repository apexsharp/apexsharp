public with sharing class ClassAuraEnabled {

    @AuraEnabled
    public String label {get; set;}


    @AuraEnabled
    public static void setInteger(Integer myInteger) {
        System.debug(myInteger);
    }
}