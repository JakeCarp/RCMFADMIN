export class Tournament {
  constructor(data) {
    this.id = data.id;
    this.date = data.date
    this.location = data.location
    this.archived = data.archived || false
    this.netIncome = data.netIncome
  }
}

