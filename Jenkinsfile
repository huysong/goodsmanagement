pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git branch: 'main',
                    url: 'https://github.com/huysong/goodsmanagement.git'
            }
        }

        stage('Build & Run with Docker Compose') {
            steps {
                script {
                    sh '''
                        docker-compose down || true
                        docker-compose build
                        docker-compose up -d
                        echo "Waiting for services to be ready..."
                        sleep 30
                    '''
                }
            }
        }

        stage('Verify Containers') {
            steps {
                script {
                    sh 'docker ps'
                }
            }
        }
    }

    post {
        always {
            script {
                // Optional clean-up or container status
                sh 'docker ps -a'
            }
        }
    }
}
