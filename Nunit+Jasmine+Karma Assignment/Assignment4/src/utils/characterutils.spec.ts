import { CharacterUtils } from "./characterUtils";
import { MockCharacterUtils } from "./MockCharacterUtils";

describe('Utility Testing : Character ', () => {

    // Using original instance of util class
    let characterUtils : CharacterUtils;

    // Using mock instance of util class
    let mockCharacterUtils : MockCharacterUtils;

    beforeEach(() => {
        characterUtils=new CharacterUtils();
        mockCharacterUtils=new MockCharacterUtils();
    });
    afterEach(()=>{
        characterUtils=null;
        mockCharacterUtils=null;
    });

    it('is my string in lower case',()=>{

        // Arrange
        let inputString="NUNIT";

        // Act
        let result=characterUtils.lowerCase(inputString);

        // Assert
        expect(result).toEqual("nunit");
    });

    it('is my string in upper case',()=>{

        // Arrange
        let inputString="nunit";

        // Act
        let result=characterUtils.upperCase(inputString);

        // Assert
        expect(result).toEqual("NUNIT");
    });

    it('is my string in propercase case',()=>{

        // Arrange
        let inputString="jasmine karma";

        // Act
        let result=mockCharacterUtils.properCase(inputString);

        // Assert
        expect(result).toEqual("Jasmine Karma");
    });

    it('is my sentence in sentence case',()=>{

        // Arrange
        let inputString="jasmine is a testing framework.it is easy.";

        // Act
        let result=mockCharacterUtils.sentenceCase(inputString);

        // Assert
        expect(result).toEqual("Jasmine is a testing framework.it is easy.");
    });

    it('remove last character of my string',()=>{

        // Arrange
        let inputString="Karma";

        // Act
        let result=mockCharacterUtils.removeLastCharacter(inputString);

        // Assert
        expect(result).toEqual("Karm");
    });


   
});

