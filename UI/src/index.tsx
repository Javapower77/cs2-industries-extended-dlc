import { ModRegistrar } from "cs2/modding";
import { VanillaComponentResolver } from "mods/VanillaComponentResolver/VanillaComponentResolver";
import mod from "../mod.json";
import { TestFieldsComponent } from "mods/TestFields/TestFields";
import { TestStorageSectionComponent } from "mods/TestFields/TestFieldsStorage";

const register: ModRegistrar = (moduleRegistry) => {

    // The vanilla component resolver is a singleton that helps extrant and maintain components from game that were not specifically exposed.
    VanillaComponentResolver.setRegistry(moduleRegistry)

    moduleRegistry.extend("game-ui/game/components/selected-info-panel/selected-info-sections/selected-info-sections.tsx", 'selectedInfoSectionComponents', TestFieldsComponent);
    moduleRegistry.extend("game-ui/game/components/selected-info-panel/selected-info-sections/building-sections/storage-section.tsx", 'StorageSection', TestStorageSectionComponent);

    console.log(mod.id + " UI: [index.tsx]::[TestFieldsComponent] -> " + TestFieldsComponent);
    console.log(mod.id + " UI: [index.tsx]::[TestStorageSectionComponent] -> " + TestStorageSectionComponent);
    console.log(mod.id + " UI: [index.tsx]:: module registrations completed!");
}

export default register;