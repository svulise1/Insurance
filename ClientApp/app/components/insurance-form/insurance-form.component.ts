import { Component, OnInit } from '@angular/core';
import { InsuranceService } from "../../InsuranceService/InsuranceService";

@Component({
  selector: 'app-insurance-form',
  templateUrl: './insurance-form.component.html',
  styleUrls: ['./insurance-form.component.css'],
  providers:[InsuranceService]
})
export class InsuranceFormComponent implements OnInit {

    companys: any[];
    instypes :any[];
    insurance: any = {};
    feature: any[];
   
  constructor(private insuranceService :InsuranceService) { }

  ngOnInit() {
      this.insuranceService.getCompany().subscribe(companys => this.companys = companys);
      this.insuranceService.getfeatures().subscribe(feature => this.feature = feature);
  }
  oncompanychange() {
 
      this.popoulate();
      
  }

  private popoulate() {
      var selectedcompany = this.companys.find(c => c.name == this.insurance.company);
      this.instypes = selectedcompany ? selectedcompany.types : [];
  }

     
}
