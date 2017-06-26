import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { sharedConfig } from './app.module';
import { InsuranceFormComponent } from './components/insurance-form/insurance-form.component';
import { FormsModule } from '@angular/forms';
@NgModule({
    bootstrap: sharedConfig.bootstrap,
    declarations: [
        ...sharedConfig.declarations,
        InsuranceFormComponent 
        
        ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        ...sharedConfig.imports
    ],
    providers: [
        { provide: 'ORIGIN_URL', useValue: location.origin }
    ]
})
export class AppModule {
}
