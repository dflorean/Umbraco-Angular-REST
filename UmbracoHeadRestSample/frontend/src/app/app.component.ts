import { Component } from '@angular/core';
import { AppService } from './app.service';
import { WeatherForecast, HomePage, FirstLevelPage, Employee } from './app.models';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'frontend';

  homePage: HomePage;
  firstLevelPage: FirstLevelPage;
  employees: Employee[] = [];
  employee: Employee;

  constructor(private appService: AppService) {}

  ngOnInit() {
    this.appService.getHomePage()
      .subscribe(
        data => this.homePage = data,
        err => alert(JSON.stringify(err))
      );

      this.appService.getFirstLevelPage()
      .subscribe(
        data => this.firstLevelPage = data,
        err => alert(JSON.stringify(err))
      );
    // this.appService.getEmployees()
    //   .subscribe(
    //     data => this.employees = data,
    //     err => alert(JSON.stringify(err))
    //   );

    //   this.appService.getEmployee(1)
    //   .subscribe(
    //     data => this.employee = data,
    //     err => alert(JSON.stringify(err))
    //   );
  }
}
