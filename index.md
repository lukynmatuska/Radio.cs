## Tasks
### RadioMessage
Parametry v konstruktoru budou implementovány jako auto property read only.

### RadioStation
Metoda `hasRadioMoneyToBroadcast` náhodně generuje událost, zdali má rádio dostatek peněz na vysílání, pokud nemá, vyvolejte výjimku `RadioBankruptException`.

Rádio bude mít také svého moderátora (stačí jméno jako `string`), moderátor bude moci být změněn vaší novou metodou.

Pokud nebude mít rádio moderátora (jméno bude `null`), pak vyvolejte vlastní novou výjimku.

Pokud bude mít rádio dostatek prostředků a moderátora pak vyvolejte `Event OnRadioBroadcast` posluchačům rádia. Autor zprávy bude aktuální moderátor.

Vytvořte vlastní `event`, který bude vyvolán při změně moderátora a implementujte reakci v posluchačích.

### OldGrandmaRadio
Třída slouží k vaší inspiraci, nicméně doimplementujte funkci, která je volána při vysílání rádia, stačí výstup do `console`.

### BrandNewRadio
Doimplementujte funkce pro zapínání, vypínání a poslech rádia.

Zařízení si také bude ukládat do svého interního seznamu historii vysílaných zpráv, bude ovšem ukládat pouze zprávy a hudbu (`RadioMessageType`).

Zařízení bude obsahovat metody na získání historie vysílaných zpráv (typ zprávy “zprávy” a “hudba”).


### Program
Metodu `WorldTick` ignorujte, berte ji jako fakt, tato metoda vám každou sekundu provolá metodu `RadioBroadcast`.

Metodu `RadioBroadcast` upravte tak, aby byla obalena try catch blokem.

Implementujte vhodné ovládání našeho rádia (zařízení) zapnout vypnout a rádiové stanice (změna moderátora).


Na závěr, fantazii se meze nekladou, překvapte mě nevšedním řešením! Například generátor random zpráv, hudby, atd. (můžete využít např. slovník). Neváhejte mě kdykoliv cokoliv napsat, zavolat, rád poradím!
