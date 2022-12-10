export class Grant {
  constructor(data) {
    this.id = data.id;
    this.amount = data.amount;
    this.name = data.name;
    this.email = data.email;
    this.department = data.department;
    this.description = data.description;
    this.budget = data.budget;
    this.trainingProvider = data.trainingProvider;
    this.createdAt = data.createdAt;
    this.updatedAt = data.updatedAt;
  }
}
