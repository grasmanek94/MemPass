function toUTF8Array(str) {
    var utf8 = [];
    for (var i=0; i < str.length; i++) {
        var charcode = str.charCodeAt(i);
        if (charcode < 0x80) utf8.push(charcode);
        else if (charcode < 0x800) {
            utf8.push(0xc0 | (charcode >> 6), 
                      0x80 | (charcode & 0x3f));
        }
        else if (charcode < 0xd800 || charcode >= 0xe000) {
            utf8.push(0xe0 | (charcode >> 12), 
                      0x80 | ((charcode>>6) & 0x3f), 
                      0x80 | (charcode & 0x3f));
        }
            // surrogate pair
        else {
            i++;
            // UTF-16 encodes 0x10000-0x10FFFF by
            // subtracting 0x10000 and splitting the
            // 20 bits of 0x0-0xFFFFF into two halves
            charcode = 0x10000 + (((charcode & 0x3ff)<<10)
                      | (str.charCodeAt(i) & 0x3ff));
            utf8.push(0xf0 | (charcode >>18), 
                      0x80 | ((charcode>>12) & 0x3f), 
                      0x80 | ((charcode>>6) & 0x3f), 
                      0x80 | (charcode & 0x3f));
        }
    }
    return utf8;
}

function generatePassword(name, login, sequenceNumber, passwordLen, password, passwordRepeat, lowercaseSelected, uppercaseSelected, numberSelected, specialSelected, spaceSelected)
{
    if (passwordLen < 1)
    {
        throw "Password passwordLen cannot be less than 1";
    }

    if (passwordLen > 64)
    {
        passwordLen = 64;
    }

    if (!lowercaseSelected && !uppercaseSelected && !numberSelected && !specialSelected && !spaceSelected)
    {
        throw "Cannot use an empty character set";
    }

    // character sets prepare

    var character_set = "";

    if (lowercaseSelected)
    {
        character_set += "abcdefghijklmnopqrstuvwxyz";
    }
    if (uppercaseSelected)
    {
        character_set += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }
    if (numberSelected)
    {
        character_set += "0123456789";
    }
    if (spaceSelected)
    {
        character_set += " ";
    }
    if (specialSelected)
    {
        character_set += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
    }

    character_set = character_set.split('').sort(); // order characters by decimal value / alphabetically

    if (password !== passwordRepeat)
    {
        throw "Master Passwords do not match";
    }

    if (password.Length < 1)
    {
        throw "Master Password cannot be empty";
    }

    var generated_password = "";

    // Generation routine here

    var login_bytes = toUTF8Array(login);
    var name_bytes = toUTF8Array(name);
    var zeroes = [ 0 ];
    var sequence_bytes = toUTF8Array(sequenceNumber);
    var password_bytes = toUTF8Array(password);
    var config_bytes = [
        0,
        lowercaseSelected ? 1 : 0,
        0,
        uppercaseSelected ? 1 : 0,
        0,
        numberSelected ? 1 : 0,
        0,
        specialSelected ? 1 : 0,
        0,
        spaceSelected ? 1 : 0,
        0,
        passwordLen,
        0
    ];
    var concatenator = [];

    var data = sha512(concatenator.concat(sequence_bytes, config_bytes, name_bytes, zeroes, login_bytes, zeroes, password_bytes).join(''));

    if (passwordLen > data.Length)
    {
        passwordLen = data.Length;
    }

    for (var i = 0; i < passwordLen; i++)
    {
        generated_password += character_set[data[i] % character_set.Length];
    }

    return generated_password;
}