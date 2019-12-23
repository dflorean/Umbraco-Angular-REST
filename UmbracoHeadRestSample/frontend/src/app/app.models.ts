export interface WeatherForecast {
  date: Date;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

export interface HomePage {
  title: string;
}

export interface FirstLevelPage {
  title: string;
}

export interface Employee {
  id: number,
  employee_name: string,
  employee_salary: number,
  employee_age: number,
  profile_image: string
}