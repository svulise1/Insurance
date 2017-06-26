import { Component, OnInit } from '@angular/core';
import { InsuranceService } from "../../InsuranceService/InsuranceService";

@Component({
  selector: 'app-insurance-form',
  templateUrl: './insurance-form.component.html',
  styleUrls: ['./insurance-form.component.css'],
  providers:[InsuranceService]
})
export class InsuranceFormComponent implements OnInit {

    company;
    insurance = {};
  constructor(private insuranceService :InsuranceService) { }

  ngOnInit() {
      this.insuranceService.getCompany().subscribe(
          company => {this.company = company,
              console.log("Company are ", this.company)
          });
  }

}
