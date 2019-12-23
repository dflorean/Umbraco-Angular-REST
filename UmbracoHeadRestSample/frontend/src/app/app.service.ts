import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../environments/environment';
import { WeatherForecast, HomePage, Employee, FirstLevelPage } from './app.models';

@Injectable({providedIn: 'root'})
export class AppService {
  constructor(private httpClient: HttpClient) { }

  getHomePage() {
    return this.httpClient.get<HomePage>(environment.apiUrl);
  }

  getFirstLevelPage() {
    return this.httpClient.get<FirstLevelPage>(environment.apiUrl + '/pagina-primo-livello/');
  }

  getEmployees() {
    return this.httpClient.get<Employee[]>('http://dummy.restapiexample.com/api/v1/employees');
  }

  getEmployee(id) {
    return this.httpClient.get<Employee>('http://dummy.restapiexample.com/api/v1/employee/' + id);
  }
}
