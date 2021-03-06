import { UnitType } from '../../models/unit-type.model';

export class FlatNode {
    id: number;
    name: string;
    data?: number | UnitType;
    level: number;
    expandable: boolean;
    isClassification: boolean;
    wasExpanded: boolean;
    isTemplate: boolean;
    isEditable:boolean;
  }

  export class ItemNode {
    id: number;
    name: string;
    data?: number | UnitType;
    children: ItemNode[] = [];
    isTemplate?: boolean;
    isEditable: boolean;
    constructor(id: number,name:string, data?: number | UnitType){
      this.id = id;
      this.name = name;
      this.data = data;
    }
  }
